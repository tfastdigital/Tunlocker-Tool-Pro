# Learning path

A study plan for this codebase, from zero to shipping your own change. Each phase has a concrete goal. Finish the goal before moving on.

## Phase 0: prerequisites

- C#, including async/await
- Windows basics: serial ports, starting processes, file IO
- USB fundamentals: endpoints, control transfers, device descriptors
- The Android boot chain: bootloader, fastboot, recovery, partitions, verified boot

## Phase 1: the UI

Open Form1.cs and the Dialog files.

1. Find the login button handler and follow it into Login.cs.
2. Pick one operation button (FRP is a good one) and trace what the code checks before it runs.
3. Read COMPortInfoB.cs and see how ports are enumerated.

Goal: explain in one paragraph how the UI talks to the operation code.

## Phase 2: ADB and fastboot

1. Read ProcessConnection.cs. Note how adb.exe and fastboot.exe are started, fed commands and read back.
2. On a test device, run the same adb and fastboot commands by hand and compare the output with what the code parses.

Goal: write a small console app that lists devices via adb.exe.

## Phase 3: MediaTek protocol

1. Read mtkclient2/MTK/ and compare it against the Python mtkclient (https://github.com/bkerler/mtkclient).
2. Map the handshake: how the device enters BROM, how the preloader gets uploaded.
3. Follow MtkTask.InitAsync and Unlock_Code_1 from Form1.cs down to the USB writes.

Goal: document one MTK command from client code to USB in docs/.

## Phase 4: Qualcomm, Samsung, Spreadtrum, Kirin

Same pattern for each chipset:

1. How the device enters its special mode (EDL, Odin download mode, SPD, DIAGNOS).
2. How the handshake works.
3. How a partition read or write is performed.

Files: EDL.cs, OdinClient/, SPD/, SPDR.cs, HuaweiUnlocker/, kirin.cs.

Goal: fill in one row of the workflow table in docs/WORKFLOW.md with exact file and method names.

## Phase 5: filesystem and crypto

1. Operations/Ext4: read the superblock parser, then directory entries, then file extraction.
2. AESS.cs and Force/Crc32: compare with FIPS-197 and the zlib CRC32 spec.
3. SymbolEnc.cs and tmpcrpt.cs: figure out what they protect and why this counts as obfuscation, not security.

Goal: add a CRC32 unit test against known vectors.

## Phase 6: the server side

1. Read docs/BACKEND_GUIDE.md.
2. Run the simplified Node backend from the guide and log in against your own server.
3. Add one endpoint of your own and call it from the client.

Goal: your client build logs into your own server.

## Phase 7: ship something

Pick one:

- Dump a partition to file with a progress bar
- Split one dialog out of Form1.cs into its own file
- Document one protocol handshake in docs/
- Add unit tests for scatter file parsing

Open a PR. See CONTRIBUTING.md.
