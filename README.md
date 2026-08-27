# Credit Card UI in .NET MAUI

This repository contains a .NET MAUI sample project that replicates a modern, interactive **Credit Card Check-Out UI**. The application demonstrates how to design a clean, responsive payment screen using XAML and the .NET MAUI framework, with support for multiple platforms including Android, iOS, macOS (Catalyst), and Windows.

The UI showcases a realistic credit card layout with card number input, cardholder name, expiration date, and CVV fields, providing a smooth user experience for payment workflows in mobile and desktop apps.

## Prerequisites

* Visual Studio 2026 with the **.NET MAUI** workload installed
* .NET 7.0 SDK or later
* Supported platform SDKs (Android API 21+, iOS 15+, macOS 12+, Windows 10 19041+)

## Features

* Cross-platform credit card check-out UI built with .NET MAUI
* Reusable `CheckOutPage` view with MVVM-friendly bindings
* Sample card and invoice models for quick prototyping
* Custom styling and resources located in `Resources/Styles`
* Support for Android, iOS, Mac Catalyst, Tizen, and Windows targets

## Project Structure

* `Models/` – Contains the `Cards` and `Invoice` data models
* `ViewModels/` – Holds the `CardsViewModel` used to drive the UI
* `Views/` – Includes the `CheckOutPage` XAML and code-behind
* `Platforms/` – Platform-specific configuration and entry points
* `Resources/` – Fonts, images, colors, and style definitions

## How to run the project

* Clone or checkout this project to a location on your disk.
* Open the `CreditCardCheckOutSample.sln` solution file using **Visual Studio 2026**.
* Restore the NuGet packages by rebuilding the solution.
* Select your desired target platform (Android, iOS, Windows, etc.) from the run menu.
* Click **Run** to deploy the app to an emulator, simulator, or physical device.

## Notes

* Make sure your development environment matches the prerequisites before building.
* If you target iOS or Mac Catalyst on Windows, you will need a Mac paired to Visual Studio for remote builds.
* Customizations such as card colors, fonts, and layout can be tweaked in the XAML files under `Views/` and `Styles/`.
