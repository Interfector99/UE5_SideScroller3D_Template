# Unreal Engine 5.4.2 Side Scroller 3D Template

Welcome to the **Unreal Engine 5.4.2 Side Scroller 3D Template** project! This template is designed to help you kickstart your own 3D side-scrolling game using Unreal Engine 5.4.2 with C++. A Blueprint version of the template is also available on a separate branch for those who prefer working with Blueprints.

## Project Overview

- **Project Name:** SideScroller3D
- **Template Name:** TP_SideScroller3D
- **Template Type:** Side Scroller in fully 3D
- **Engine Version:** Unreal Engine 5.4.2
- **Language:** C++

## Branches

- **main:** C++ version of the Side Scroller 3D Template.
- **blueprints:** Blueprint version of the Side Scroller 3D Template (coming soon).

## Features
Derived from Unreal Engine's third person template. No changes were made except listed under. No external assets or starter content is used, only the built-in.
- **Naming**
  - Renamed everything from **ThirdPerson** to **SideScroller3D**.
- **Camera Setup:** 
  - Deleted the IA_Look input action.
  - Configured the camera to only look at the player from the negative X axis.
  - Elevated the SpringArm so the camera looks above the player by 150.
  - Removed the code responsible for camera look controls in the **SideScroller3DCharacter**.
- **SpringArm Configuration:**
  - Disabled collision checks for the SpringArm component to maintain a constant camera distance.
- **Basic Side Scroller Map:**
  - Included a simple map where the player can run and jump for testing purposes and set it to default.
- **GameMode**
  - Made a gamemode blueprint from the SideScrollerTemplateGameMode called BP_SideScrollerTemplateGameMode and set it to default.

## How to Install
1. Download the latest release
2. Unpack the ZIP file
3. Paste it into your UnrealEngineInstallation/Templates folder
More information: [https://cobracode.notion.site/How-to-install-an-Unreal-Engine-Template-b7fe36e8f9d142b2b02a4fc88600b0f9](https://cobracode.notion.site/How-to-install-an-Unreal-Engine-Template-b7fe36e8f9d142b2b02a4fc88600b0f9)

## How to make templates yourself
[https://www.youtube.com/watch?v=qdYg9JAuLgU](https://www.youtube.com/watch?v=qdYg9JAuLgU)