# Unity VR Basic Template

This repository serves as a personal **Unity VR project template** that I use whenever I start a new VR development project. 
It includes all the necessary packages, input configurations, and basic functionality set up — so I can hit the ground running without having to redo setup each time.

---

## Features

- XR Interaction Toolkit (Unity's official package for VR)
- Movement
  - Left Controller (Joystick): Smooth locomotion (basic walking movement)
  - Right Controller (Joystick North Push + Release): Teleportation to valid surfaces using a Teleportation Ray

- UI Interactions
  - Ray Interactor setup for UI (displays visual indicator when hovering over buttons)
  - Includes example button with visual feedback (Light enabled over the grabbable block)
  - A script to interact with the UI (so in the future, I can add more functionality without having to use the default button)
    
- Layer Masks
  - Predefined layer masks for:
    - `Grab`
    - `Socket`
    - `UI`

---

## Purpose

This template helps me avoid repetitive setup and ensures all essential components are already in place for fast prototyping or project creation.

- Unity 2021.3 LTS 
- XR Plugin Management
- XR Interaction Toolkit (installed via Unity Package Manager)

---
