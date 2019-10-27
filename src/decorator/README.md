## Type

Structural Pattern: Decorator

## Role

The role of the Decorator pattern is to provide a way of attaching new state and behaviour to an object dynamically.

The object does not know it is being decorated which makes this a useful pattern for evolving systems.

A key implemenation point if this pattern is that decorators both inhetir the origina clas and contain an instantiation of it.



| Item        | Purpose           | Notes  |
| ------------- |:-------------|:-----|
| IVehicle      | Any vehicle |  |
| Vehicle      | A plain vehicle|  |
| GetDescription      | Get the description of the vehicle |  |
| Client      | Creator of vehicles, cars and vans |  |
| Car      | A vehicle with characteristics of a car |  |
| Van      | A vehicle with characteristics of a car |  |
