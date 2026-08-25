# Security

If you find a security problem in this software, do not open a public issue. Report it privately:

- Telegram: https://t.me/tfasthub
- WhatsApp: +256 751 399 620

Include a short description, the affected code path and steps to reproduce.

## Known limitations

- The release exe is not code-signed. Windows Defender flags phone tools as PUP.
- The request encryption between client and server uses a static key embedded in the client. It is obfuscation, not security. Details in docs/BACKEND_GUIDE.md.
- There are no unit tests yet.
- Passwords are sent as part of the login payload. Always run the client against servers using TLS.

## Reporting a vulnerable dependency

Open an issue and name the dependency and version. List of direct dependencies is in Tunlocker Tool.csproj and the Res folder.
