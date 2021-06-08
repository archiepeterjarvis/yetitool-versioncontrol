# yetitool-versioncontrol

## Overview

Yeti Tool Version Control is a simple API to manage latest releases for SmartTransfer.

## JSON Format

```json
{
   "Latest": "0.2.0",
   "UpdateLog": [
      "SmartTransfer will now prompt you when updates are available"
   ]
}
```

"Latest" refers to the newest release of SmartTransfer. This needs to be synced with the project version to prompt correctly.
"UpdateLog" is a list of changes that will be displayed line by line to the user.

Please store this in versions.json

