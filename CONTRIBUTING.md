# Contributing

Thanks for helping. This is a source release of a commercial tool, so parts of the code are old and rough. The most useful contributions right now:

- Documentation and code comments
- Unit tests for CRC32, AES and scatter file parsing
- Splitting Form1.cs into smaller files
- Bug reports with clear reproduction steps

## Rules

- Legal use only. No malware, no bypass tooling for devices you don't own.
- Do not commit bin/, obj/ or .vs/.
- Do not commit license credentials, private server keys or customer data.

## Setup

```bash
git clone https://github.com/tfastdigital/Tunlocker-Tool-Pro.git
cd Tunlocker-Tool-Pro
dotnet build "Tunlocker Tool.sln" -c Debug
```

## Pull requests

1. Fork the repo and branch off main.
2. Keep changes small and focused.
3. Make sure the build still passes (it prints warnings, that is fine, errors are not).
4. Write a clear PR description: what changed and why.

## Style

- The existing code style is inconsistent because the code is decompiled. Match the file you are editing.
- Documentation is written plain: no emoji in headings, short sentences, no hype.

## Reporting bugs

Use the bug report template. Include the tool version, the device and chipset, what you expected, what happened, and relevant log output.
