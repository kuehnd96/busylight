# Work From Home Busy Light
My maiden voyage into programming on my Raspberry Pi 🥧 to create a busy light for working from home

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
- Visual Studio 2022
- Github (source control and work tracking)
