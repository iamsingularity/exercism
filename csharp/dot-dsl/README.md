# Dot Dsl

Write a Domain Specific Language similar to the Graphviz dot language

A [Domain Specific Language
(DSL)](https://en.wikipedia.org/wiki/Domain-specific_language) is a
small language optimized for a specific domain.

For example the dot language of [Graphviz](http://graphviz.org) allows
you to write a textual description of a graph which is then transformed
into a picture by one of the graphviz tools (such as `dot`). A simple
graph looks like this:

    graph {
        graph [bgcolor="yellow"]
        a [color="red"]
        b [color="blue"]
        a -- b [color="green"]
    }

Putting this in a file `example.dot` and running `dot example.dot -T png
-o example.png` creates an image `example.png` with red and blue circle
connected by a green line on a yellow background.

Create a DSL similar to the dot language.

### Submitting Exercises

Note that, when trying to submit an exercise, make sure you're exercise file you're submitting is in the `exercism/csharp/<exerciseName>` directory.

For example, if you're submitting `bob.cs` for the Bob exercise, the submit command would be something like `exercism submit <path_to_exercism_dir>/csharp/bob/bob.cs`.
## Hints
This exercise requires you to implement classes with a custom equality check. For more information, see [this page](https://msdn.microsoft.com/en-us/library/bsc2ak47(v=vs.110).aspx).



## Submitting Incomplete Problems
It's possible to submit an incomplete solution so you can see how others have completed the exercise.

