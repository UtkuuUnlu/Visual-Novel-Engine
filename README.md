This system is being built following the architectural patterns taught by **Stellar Studios**, implemented by hand to understand core narrative systems in Unity.
While there are dedicated tools for making visual novels, I chose to build this framework from scratch in Unity to allow for deep gameplay integration. By building my own engine, I can seamlessly transition between narrative scenes and complex gameplay mechanics.

Current Development

Regex Command Parsing [COMPLETED]: Implemented an advanced Regex-based parser that interprets dialogue scripts in real-time. This allows the engine to distinguish between spoken text, internal logic, and character Aliases, ensuring that script-writing is fast and error-free.

Dynamic Typecasting [COMPLETED]: Implemented a character-profile system. The UI now automatically "typecasts" itself based on the speaker—instantly swapping fonts, hex colors, and nameplates by pulling data from ScriptableObject profiles.

Command Database [COMPLETED]: The registry for game actions is fully functional. The system is designed to be infinitely extensible; I can now register any custom C# method as a command and call it directly from the dialogue script.

Core Command Library [IN PROGRESS]: While the database logic is finished, I am currently writing the specific library of commands.
