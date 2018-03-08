# The Reticulator
A Simple Playground For Cubic Bezier Splines



This is just a simple little program that displays a single cubic Bezier spline and lets you drag around the control points.

Control points can also be edited by hand (in pixel/screen space) if you prefer that to mouse interactions.

The code provides an implementation of parametric splines (i.e. controlling a `t` value from 0 to 1) and demonstrates how to approximate arc-length using a few different methods. It also shows how to compute first and second order differentials of the Bezier equation, which can be useful for finding tangents (and therefore normals), as well as acceleration calculations.

![A screenshot of The Reticulator](https://raw.githubusercontent.com/apoch/TheReticulator/master/Screenshot.png)

Mostly just putting this out there for anyone who might find it handy; suggestions for additions/changes are welcome.

The name is a reference to SimCity 2000.