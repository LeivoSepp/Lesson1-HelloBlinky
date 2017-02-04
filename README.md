# Lesson #1 Hello Blinky
Windows 10 IoT Core first lesson to try something simple with Raspberry PI. Just blinking onboard green led.

HelloBlinky is one of the shortest and easily understandable program which illustrates Raspberry PI GPIO programming.

In the following example we are using Raspberry PI with Windows 10 IoT Core.

Here is the blog entry: https://github.com/LeivoSepp/Lesson1-HelloBlinky

Lesson #2 https://github.com/LeivoSepp/Lesson2-HelloBlinkyRedGreen

Lesson #3 https://github.com/LeivoSepp/Lesson3-HelloButton

## What is GPIO?

**GPIO** stands for general-purpose input/output and it is a generic pin on a Raspberry/Arduino board. Each pin can be configured to be input or output.

## Pin is configured as an input

Use it for buttons, measuring temperature, measuring light,  measuring distance 

## Pin is configured as an output

Use it for LEDs, motors, relays, lamps

## Pin identification number

Each pin has its own personal number. This number is used to communicate with the pin. The pin number to use to communicate has an orange background. Do not try to use the numbers with grey backgrounds! It wont work and you will get an error.

<img src="http://internetofthing.io/posts/files/9f2da784-623e-4753-b521-59ea81b6f2c3.png" />

Raspberry PI has two special pins which are to control the green and red LED integrated on the board. 

The green LED’s pin number is 35 and the red’s pin number is 47.

## Windows 10

To set up Windows 10 IoT Core to your Raspberry, please follow the instructions here: https://developer.microsoft.com/en-us/windows/iot/Docs/GetStarted/rpi2/sdcard/stable/getstartedstep1 

## Visual Studio

To start new Raspberry project, use the Visual Studio template “Background Application (IoT)”.

<img src="http://internetofthing.io/posts/files/acc2be75-7380-42a2-bce4-164157b551a5.png" />

If you do not have this project template, then open menu Visual Studio –> Tools –> Extensions and Updates. From there, click online, search for the string “iot” and install “Windows IoT Core Project Templates for VS”.

<img src="http://internetofthing.io/posts/files/a65a0012-adad-43b7-8bd5-c363cd40d322.png" />

# Blinky code and explanation.

<img src="http://internetofthing.io/posts/files/2cfbea38-ea7b-4449-906f-26f92f7e558d.png" />
