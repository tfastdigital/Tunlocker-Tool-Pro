# Lab setup

A safe practice environment for learning this codebase and testing changes without bricking a phone you care about. The tool talks to real hardware over USB in low-level modes, so a throwaway test device and good backups matter more here than in normal software work.

Pairs with [LEARNING_PATH.md](LEARNING_PATH.md) (what to study) and [PROTOCOLS.md](PROTOCOLS.md) (what you'll be poking at). Read [LEGAL_AND_ETHICS.md](LEGAL_AND_ETHICS.md) first — only use devices you own.

---

## 1. The golden rule

Every low-level write is potentially destructive. Before your first flash on any device:

1. **Own the device.** Buy a cheap test unit; never practice on someone else's phone.
2. **Back up first.** Read out the partitions you're about to touch (especially modem/NV/EFS — IMEI lives there and is often unrecoverable). The tool's read operations exist for exactly this.
3. **Expect to brick at least one device while learning.** Budget for it. A dead-but-recoverable phone is a normal part of the learning curve.

---

## 2. Hardware

### Test phones (buy used, cheap)

Pick devices that match the chipset paths in this tool and that have a strong community (test points, loaders, firmware on XDA):

| Chipset path | Good cheap learners | Why |
| --- | --- | --- |
| MediaTek (BROM/DA) | older MTK Helio phones (e.g. Redmi/Realme budget models) | kamakiri-class support in `mtkclient2/`, well documented |
| Qualcomm (EDL) | older Snapdragon budget phones | Sahara/Firehose, easy EDL test points |
| Samsung (Odin) | any old Galaxy A/J series | download mode is button-only, low risk |
| Unisoc (SPD) | ultra-budget Spreadtrum phones | ResearchDownload, very cheap to replace |

Two of the same model is ideal: one to break, one as a known-good reference.

### Bench tools

- **USB**: a powered USB 2.0 hub (some BROM/EDL modes are fussy on USB 3 ports), plus several known-good data cables. Bad cables cause most "device not detected" mysteries.
- **Test-point kit**: fine tweezers or test-point jig to short EDL/BROM pads.
- **Optional**: a UMT/EDL cable or deep-flash cable for forcing download mode.

---

## 3. Windows setup

The tool is Windows-only (WinForms, net472). See the [README](../README.md) build steps.

1. **Drivers** — install the mode-specific USB drivers:
   - Qualcomm QDLoader 9008 (EDL)
   - MediaTek USB VCOM / preloader drivers
   - Samsung USB drivers (Odin)
   - SPD/Unisoc drivers
   Use a dedicated test PC or a VM snapshot — phone drivers are messy and easy to want to roll back.
2. **Disable driver signature issues** only if a specific driver needs it, and re-enable after.
3. **Defender** — as the README notes, phone tools get flagged as PUP. Add the working folder to exclusions on the *test* machine only.
4. **Build from source** so you can set breakpoints:
   ```bash
   dotnet build "Tunlocker Tool.sln" -c Debug
   ```
   Then run under the Visual Studio debugger (F5) so you can watch `COMPortInfoB.cs` enumerate ports and step through a handshake.

---

## 4. A safe first exercise (no writes)

Do a full round-trip that only *reads*, so a mistake costs nothing:

1. Boot a test phone into its download mode (see [PROTOCOLS.md](PROTOCOLS.md) for how each family enters).
2. Confirm the COM port appears (Device Manager, and in the tool's port list).
3. Run a **read GPT / partition list** operation. Watch the code path:
   - Qualcomm: `SAHARA.cs` → `FIREHOSE_GPT.cs`
   - MediaTek: `mtkclient2/` handshake → `MtkGpt.cs`
4. Read a small, non-critical partition to a file and inspect it with a hex editor against [FILE_FORMATS.md](FILE_FORMATS.md).

Goal: see a real device answer, and match the bytes to the documented structures — before you ever write.

---

## 5. Recovering a bricked test phone

This is a skill, not a failure. Common recoveries:

- **Won't boot but download mode works** → reflash the stock firmware for that exact model.
- **No download mode** → use the **test point** to force the boot ROM (BROM/EDL) into download mode even with dead flash. This is why test-point-friendly phones make the best learners.
- **Dead modem / bad IMEI** → restore the EFS/NV backup you took in step 2 of §1. If you didn't take one, this is the lesson about why you always do.

Keep a folder per test device with: stock firmware, your partition backups, and the test-point photo.

---

## 6. Capturing protocol traffic (optional, advanced)

To really understand [PROTOCOLS.md](PROTOCOLS.md), watch the wire:

- **USBPcap + Wireshark** to capture USB bulk transfers during a known operation, then correlate packets with the code in `FIREHOSE.cs` / `SAHARA.cs`.
- Add temporary logging in `SerialCOM.cs` / `PortIOMe.cs` to dump sent/received bytes while you learn (remove before committing).

---

## 7. Checklist before any write on a new model

- [ ] I own this device.
- [ ] Stock firmware for this exact model is downloaded.
- [ ] I have read backups of the partitions I'm touching (and of EFS/NV).
- [ ] I know the test-point location for this device.
- [ ] I'm on the test PC / VM snapshot, not my main machine.
- [ ] I've traced the code path I'm about to run.

If any box is unchecked, read more, don't flash.
