# Public release security checklist

This document is a proposed release checklist, not a certification or completed security audit.

## Before publishing

- [ ] Remove production credentials and privileged demo accounts from documentation, source and release archives; rotate any exposed credentials.
- [ ] Use isolated, restricted demo accounts with no real customer data or credit spending.
- [ ] Check source and Git history for tokens, keys, signing material and backend secrets.
- [ ] Confirm all authentication, licensing and credit decisions are enforced server-side.
- [ ] Verify that debug logs do not record passwords, tokens, IMEI or customer data unnecessarily.
- [ ] Run a clean Windows build and automated malware scan.
- [ ] Publish a SHA-256 checksum, signed binary when available, supported Windows versions and changelog.
- [ ] Provide a false-positive reporting path instead of blanket antivirus exclusions.
- [ ] Validate update download URLs and artifact integrity before execution.
- [ ] Verify third-party code and binary licenses and attribution.

## Immediate documentation follow-up

The current README includes a demonstration login and recommends Microsoft Defender exclusions. Review and replace these statements **after** verifying the demo account is isolated and a supported distribution path exists. Do not assume a credential is harmless merely because it is called a demo.

## Reporting

Do not publish credentials, tokens, private keys or customer records in public issues. Contact the maintainers privately through the official agency website.
