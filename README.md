# Introduction
A short challenge solved in C# through a command line application.

My program:

- Generates a `Grid` for `Event`'s to be placed.
- Generates seed data for `Event`'s:
    + Each `Event` has a `Coordinate`.
    + Each `Event` has a Unique ID
    + Each `Event` has 0 or more `Ticket`'s
    + Each `Ticket` has a non-zero price
    + The distance between two points is calculated as the `Manhattan distance`
- The user enters two coordinates _(signed or unsigned)_ seperated by any character.
- The program will return a list of the five closest `Event`'s displaying the cheapest `Ticket` for that `Event`.

# Assumptions

- Each `Event` can have differently priced individual tickets.
- To support multiple events at one `Location`, rather than the `Location` being a paramater of `Event`, the `Location` would be an instance, and have `Events` as one of it's properties
- The user will input two coordinates __(can be signed)__ between (-10,-10) (10,10). There will be a character or space between the two coordinates.
- The `Event` stores the tickets in ascending order by price.
- All data is randomly generated per runtime.
- If their are no `Ticket`'s for an `Event` a message will show to tell the user.

# Prerequisites

I used Visual Studio Community 17 to create and build this. To build it yourself please use:

- [Visual Studio Community](https://www.visualstudio.com/downloads/?rr=https%3A%2F%2Fwww.google.co.uk%2F)

# Usage
Clone the repo through your CLI:

```git clone git@github.com:KeirSweeney/GridChallenge.git``` -  or download as a [Zip](https://github.com/KeirSweeney/GridChallenge/archive/master.zip)


Open the __Grid Challenge__ folder after cloning and open the `GridChallenge.sln` file.

Once open use 'F5' or the 'Start' button at the top to run the command line application.

**Alternatively** the zipped Debug folder which holds the `.exe` is available [here](https://github.com/KeirSweeney/GridChallenge/raw/master/Debug.zip)

__Please note that I do not recomend you download the Debug zip directly. 
Windows will protect you from opening it and generally opening unknown `.exe`'s can be dangerous.
I have hosted this in the case the application won't build on your machine.__

# Author 

**Keir Sweeney** - [Github](https://github.com/KeirSweeney/)




