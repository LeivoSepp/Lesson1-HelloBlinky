# Lesson1-HelloBlinky
Windows 10 IoT Core first lesson to try something simple with Raspberry PI. Just blinking onboard led.

HelloBlinky is one of the shortest and easily understandable program which illustrates Raspberry PI GPIO programming.

In the following example we are using Raspberry PI with Windows 10 IoT Core.

http://internetofthing.io/post/hello-blinky-first-lesson-in-raspberry-pi

# What is GPIO?

GPIO stands for general-purpose input/output and it is a generic pin on an Raspberry/Arduino board. GPIO pins can be configured to be input or output.

# Pin is configured as an input

use it for buttons, measuring temperature, measuring light,  measuring distance 

# Pin is configured as an output

use it for led-s, motors, relay’s, lamps

# Pin identification number

Each pin has its own personal number. This number is used to communicate with the pin. The correct pin number which used to communicate is in the orange background. Do not try to use those numbers with grey background!

<img src="http://internetofthing.io/posts/files/9f2da784-623e-4753-b521-59ea81b6f2c3.png" />

Raspberry PI has two special pin’s, these are onboard green and red led. Green led pin number is 35 while red led pin number is 47.

# Windows 10

To set up Windows 10 IoT Core to your Raspberry, please follow the instructions here: https://developer.microsoft.com/en-us/windows/iot/Docs/GetStarted/rpi2/sdcard/stable/getstartedstep1 

# Visual Studio

To start new Raspberry project, use the Visual Studio template “Background Application (IoT)”.

# Visual Studio Background Application IoT

If you do not have this project template, then open menu Visual Studio –> Tools –> Extensions and Updates. Click online, search string “iot” and install “Windows IoT Core Project Templates for VS”.

# Visual Studio Tools Extensions and Updates


# Blinky code and explanation.

Blinky code and explanation
