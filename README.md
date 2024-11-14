# CounterstrikeSharp - Max PLayers per Team Override

[![UpdateManager Compatible](https://img.shields.io/badge/CS2-UpdateManager-darkgreen)](https://github.com/Kandru/cs2-update-manager/)
[![GitHub release](https://img.shields.io/github/release/Kandru/cs2-max-team-players-override?include_prereleases=&sort=semver&color=blue)](https://github.com/Kandru/cs2-max-team-players-override/releases/)
[![License](https://img.shields.io/badge/License-GPLv3-blue)](#license)
[![issues - cs2-map-modifier](https://img.shields.io/github/issues/Kandru/cs2-max-team-players-override)](https://github.com/Kandru/cs2-max-team-players-override/issues)
[![](https://www.paypalobjects.com/en_US/i/btn/btn_donateCC_LG.gif)](https://www.paypal.com/donate/?hosted_button_id=C2AVYKGVP9TRG)

This tool overrides the maximum players per team to allow more then 5vs5 on Competitive servers.

## Installation

1. Download and extract the latest release from the [GitHub releases page](https://github.com/Kandru/cs2-max-team-players-override/releases/).
2. Move the "Cosmetics" folder to the `/addons/counterstrikesharp/configs/plugins/` directory.
3. Restart the server.

Updating is even easier: simply overwrite all plugin files and they will be reloaded automatically. To automate updates please use our [CS2 Update Manager](https://github.com/Kandru/cs2-update-manager/).


## Configuration

This plugin automatically creates a readable JSON configuration file. This configuration file can be found in `/addons/counterstrikesharp/configs/plugins/MaxTeamPlayersOverride/MaxTeamPlayersOverride.json`.

## Compile Yourself

Clone the project:

```bash
git clone https://github.com/Kandru/cs2-max-team-players-override.git
```

Go to the project directory

```bash
  cd cs2-max-team-players-override
```

Install dependencies

```bash
  dotnet restore
```

Build debug files (to use on a development game server)

```bash
  dotnet build
```

Build release files (to use on a production game server)

```bash
  dotnet publish
```

## FAQ

TODO

## License

Released under [GPLv3](/LICENSE) by [@Kandru](https://github.com/Kandru).

## Authors

- [@derkalle4](https://www.github.com/derkalle4)
- [@jmgraeffe](https://www.github.com/jmgraeffe)
