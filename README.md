# Work From Home Busy Light
My maiden voyage into programming on my Raspberry Pi 🥧 to create a busy light for working from home

## Status

3/20/2022: Upon further review the library I was going to use to interact with the Blinkt hardware is not complete and won't work. My search for any .NET libraries that interact with the Blinkt hardware (or any Pimoroni hardware) came up with nothing. Thus, I am back to square one which is trying to get the original instruactions working. Right now this repo will lay dormant. Perhaps some day I will have to the time to implement interaction with the Blinkt in .NET or something else will come available. I am bummed because I was excited about being able to improve this busy light over time.


## Motivation

I have been working from home since 2017 and I really enjoy it. I thought it would be nice to have a busy light to signal when I am in a meeting to let my wife and kids know when not to come into my office. I found some great instructions and [code](https://github.com/jimbobbennett/BusyLight/tree/master) by [Jim Bennett](https://github.com/jimbobbennett) but multiple attempts to get the Python code running on my Pi board failed. After searching for .NET code that would work with these instructions turned up nothing I decided to jump into the world of Windows IoT and implement the code for the Raspberry Pi myself.

## Phase 1

My plan is to implement the .NET code to turn the light on the Pi on when I am in a meeting and off when I am no longer in a meeting. Here is my path for this phase:

1. Set up my development environment by getting Window IoT on to the memory card for my Pi board
2. Try one of the sample applications to get a feel for .NET running on a Raspberry Pi
3. Finish setting up my Azure infrastructure using my original set of directions
4. Get a feel for the library that allows me to control my Blinkt light by creating a sample application and testing on the Pi
5. Create the busy light solution that will light the light when I am in a meeting

## Future phases?

- Turn light yellow in the 5 mintues leading up to a meeting
- Create a mobile app that also responds to my status

## Technologies

- .NET 6
- C#
- [Window IoT Core](https://developer.microsoft.com/en-us/windows/iot/)
- Azure (Iot Central, Logic Apps)

## Tools
- [Raspberry Pi 3](https://www.raspberrypi.com/products/raspberry-pi-3-model-b-plus/)
- Visual Studio 2019
- Github (source control and work tracking)

## Resources
- [Setting up a Raspberry Pi 3](https://docs.microsoft.com/en-us/windows/iot-core/tutorials/rpi)
- [A .NET Core library for interacting with Blinkt!](https://gitlab.com/ferrodev/blinkt-dotnet)
- [Azure IoT Central documentation](https://docs.microsoft.com/en-us/azure/iot-central/#step-by-step-tutorials)
- [Building Apps for Windows IoT Core](https://docs.microsoft.com/en-us/windows/iot-core/develop-your-app/buildingappsforiotcore)
- [Developing Backround Applications](https://docs.microsoft.com/en-us/windows/iot-core/develop-your-app/backgroundapplications)


