# GridChallenge
A short challenge solved in C#

# Assumptions
- Each `Event` can have differntly priced individual tickets.
- To support multiple events at one `Location`, rather than the `Location` being a paramater of `Event`, the `Location` would be an instance, and have `Events` as one of it's properties
- The user will input two coordinates __(can be signed)__ between (-10,-10) (10,10). There will be a character or space between the two coordinates.
- The `Event` stores the tickets in ascending order by price.
