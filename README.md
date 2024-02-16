# CS2 Rock The Vote
![image](https://github.com/abnerfs/cs2-rockthevote/assets/14078661/a603d1b6-ba35-4d5a-b887-1b14058a8050)

General purpose map voting plugin, started as a simple RTV and now has more features

## RockTheVote
Players can type rtv to request the map to be changed, once a number of votes is reached (by default 60% of players in the server) a vote will start for the next map, this vote lasts up to 30 seconds (hardcoded for now), in the end server changes to the winner map.

## End of map vote
Based on mp_timelimit and mp_maxrounds cvar before the map ends a RTV like vote will start to define the next map, it can be configured to change immediatly or only when the map actually ends

## Votemap
Players can vote to change to an specific map by using the votemap <mapname> command

## Timeleft
Players can type `timeleft` to see how much time is left in the current map 

# Features
- Reads from a custom maplist
- RTV Command
- Timeleft command
- Nominate command
- Nomination chat menu
- Votemap command
- Votemap chatmenu
- Supports workshop maps
- Configurable 
  

# Limitations
 - Plugins is still under development and a lot of functionality is still missing like a proper end of map vote.
 - Previous version relied on the official CS2 vote system, I pivoted this idea in favor of adding the nominate command, I will probably create another plugin with the original idea as soon as I figure out how to do the nominate command that way.
 - I usually test the new versions in an empty server with bots so it is hard to tell if everything is actually working, feel free to post any issues here or in the discord thread so I can fix them https://discord.com/channels/1160907911501991946/1176224458751627514
  
## Requirements
[Latest release of Counter Strike Sharp](https://github.com/roflmuffin/CounterStrikeSharp)

# Instalation
- Download the latest release from https://github.com/abnerfs/cs2-rockthevote/releases
- Extract the .zip file into `addons/counterstrikesharp/plugins`
- Enjoy

# Config
- A config file will be created in `addons/counterstrikesharp/configs/plugins/RockTheVote` the first time you load the plugin.
- Changes in the config file will require you to reload the plugin or restart the server (change the map won't work).

```json
{
  "Version": 7,
  "Rtv": {
    "Enabled": true,
    "EnabledInWarmup": true,
    "MinPlayers": 0,
    "MinRounds": 0,
    "ChangeMapImmediatly": true,
    "MapsToShow": 6,
    "VoteDuration": 30,
    "VotePercentage": 60,
    "HudMenu": true
  },
  "Votemap": {
    "Enabled": true,
    "VotePercentage": 60,
    "ChangeMapImmediatly": true,
    "EnabledInWarmup": true,
    "MinPlayers": 0,
    "MinRounds": 0
  },
  "EndOfMapVote": {
    "Enabled": true,
    "MapsToShow": 6,
    "HudMenu": true,
    "ChangeMapImmediatly": false,
    "VoteDuration": 30
  }
}
```

Maps that will be used in RTV/nominate/votemap are located in addons/counterstrikesharp/configs/plugins/RockTheVote/maplist.txt
