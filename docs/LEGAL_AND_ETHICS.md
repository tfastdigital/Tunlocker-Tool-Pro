# Legal and ethics

This tool performs operations — FRP removal, bootloader unlock, IMEI operations, partition read/write — that are legitimate for repair and illegal for theft. The difference is entirely **authorization**. This document sets out the boundary so the project, and anyone using it, stays on the right side of it.

This is engineering and policy guidance, not legal advice. Laws differ by country; when in doubt, consult a lawyer in your jurisdiction. Cross-references: [SECURITY_CONCEPTS.md](SECURITY_CONCEPTS.md) (why the locks exist) and the [README](../README.md) legal note.

---

## 1. The one rule

**Only operate on a device you own or are explicitly authorized to service.**

That single rule covers almost everything. The same FRP-removal that rescues a customer who forgot their own Google password also reactivates a stolen phone. The code cannot tell the two apart — the operator's authorization is what makes it legal.

---

## 2. Legitimate uses

- **Repair on owned devices** — you bought it, you can service it (right-to-repair).
- **Authorized service** — a repair shop working on a customer's device, with the customer present or with a signed work order.
- **Refurbishment** — processing traded-in or returned stock with documented chain of ownership.
- **Forgotten-credential recovery** — an owner who can prove the device is theirs but lost the account.
- **Development and research** — unlocking your own device to flash custom firmware, or studying the protocols (this repo's educational purpose).
- **Original IMEI restoration** — rewriting a device's **own** original IMEI after an EFS/NV corruption during service.

## 3. Prohibited uses

- Bypassing FRP or locks on **stolen or found** phones.
- **Changing/cloning an IMEI** to a number that is not the device's original (illegal in most countries — UK, EU, Australia, and others criminalize it explicitly).
- Servicing a device **without the owner's authorization**.
- Removing anti-theft protection to **resell** stolen stock.
- Defeating protections to access **someone else's private data**.

If an operation's main effect is to help someone use hardware or data that isn't theirs, it's out of scope for legitimate use — regardless of what's technically possible.

---

## 4. Why these protections exist

Every lock this tool touches was built to stop theft or fraud, and that's a good thing:

| Protection | Protects | See |
| --- | --- | --- |
| FRP | Makes a stolen, wiped phone useless | [SECURITY_CONCEPTS.md](SECURITY_CONCEPTS.md) §4 |
| Bootloader lock | Stops tampered firmware; unlock forces a data wipe | §3 |
| Verified boot | Stops malware replacing the OS | §1 |
| IMEI integrity | Stops device-identity cloning | §5 |

Respecting these by default — and only working around them with authorization — is what separates a repair professional from an accessory to theft.

---

## 5. Records a professional keeps

For a service business, documentation is both good ethics and legal protection. For each job, keep:

- Proof of ownership or a signed authorization / work order.
- Customer ID and contact details.
- Device IMEI(s) and model, recorded **before** and after.
- The operation performed, date, and technician.
- For IMEI work: evidence the number restored is the device's original (e.g. the label under the battery, the box).

If law enforcement ever asks why you unlocked a specific device, these records are the answer. The tool's own audit/logging habits ([BACKEND_GUIDE.md](BACKEND_GUIDE.md)) support this on the licensing side; keep operational records on the shop side too.

## 6. Checking a device isn't stolen

Before servicing a device you didn't previously own:

- Ask for proof of purchase.
- Check the IMEI against a blocklist service (e.g. national stolen-phone registries / IMEI check services).
- Be suspicious of multiple identical wiped devices from one seller.

A shop that skips these becomes the laundering step in a phone-theft chain, even unknowingly.

---

## 7. Software licensing and this repository

- The tool's own **license and credit system** is a separate matter from device law: using the tool without a valid license is piracy of the software (see [STARTUP_GUIDE.md](STARTUP_GUIDE.md) / [BACKEND_GUIDE.md](BACKEND_GUIDE.md)).
- This repository is decompiled/rebranded source kept for study and servicing. Respect the project [LICENSE](../LICENSE) and the third-party components under `Res/` (Guna.UI2, FireSharp, Newtonsoft.Json, etc.), each under its own terms.
- Contributions that add **theft-enabling** shortcuts (stolen-device workflows, IMEI-cloning helpers) are out of scope and should be rejected in review — see [CONTRIBUTING.md](../CONTRIBUTING.md).

---

## 8. Jurisdiction quick notes

Non-exhaustive, and changes over time — verify locally:

- **IMEI change** is a specific criminal offence in many countries (e.g. UK Mobile Telephones (Re-programming) Act; similar laws across the EU and Australia). Original-IMEI *restoration* is generally allowed; *changing* it is not.
- **Circumventing access controls** may engage anti-circumvention law (e.g. DMCA §1201 in the US), though repair exemptions have been expanding.
- **Right-to-repair** legislation is growing and generally supports servicing owned devices — but never overrides theft law.

When a request would require you to ignore §1, stop. No technical capability justifies unauthorized access.
