# Bowling

Score a bowling game

Bowling is game where players roll a heavy ball to knock down pins
arranged in a triangle. Write code to keep track of the score
of a game of bowling.

## Scoring Bowling

The game consists of 10 frames. A frame is composed of one or two ball throws with 10 pins standing at frame initialization. There are three cases for the tabulation of a frame.

* An open frame is where a score of less than 10 is recorded for the frame. In this case the score for the frame is the number of pins knocked down.

* A spare is where all ten pins are knocked down after the second throw. The total value of a spare is 10 plus the number of pins knocked down in their next throw.

* A strike is where all ten pins are knocked down after the first throw. The total value of a strike is 10 plus the number of pins knocked down in their next two throws. If a strike is immediately followed by a second strike, then we can not total the value of first strike until they throw the ball one more time.

Here is a three frame example:

| Frame 1         | Frame 2       | Frame 3                |
| :-------------: |:-------------:| :---------------------:|
| X (strike)      | 5/ (spare)    | 9 0 (open frame)       |

Frame 1 is (10 + 5 + 5) = 20

Frame 2 is (5 + 5 + 9) = 19

Frame 3 is (9 + 0) = 9

This means the current running total is 48.

The tenth frame in the game is a special case. If someone throws a strike or a spare then they get a fill ball. Fill balls exist to calculate the total of the 10th frame. Scoring a strike or spare on the fill ball does not give the player more fill balls. The total value of the 10th frame is the total number of pins knocked down.

For a tenth frame of X1/ (strike and a spare), the total value is 20.

For a tenth frame of XXX (three strikes), the total value is 30.

## Requirements

Write code to keep track of the score of a game of bowling. It should
support two operations:

* `roll(pins : int)` is called each time the player rolls a ball.  The
  argument is the number of pins knocked down.
* `score() : int` is called only at the very end of the game.  It
  returns the total score for that game.


## Getting Started

For installation and learning resources, refer to the
[exercism help page](http://exercism.io/languages/haskell).

## Running the tests

To run the test suite, execute the following command:

```bash
stack test
```

#### If you get an error message like this...

```
No .cabal file found in directory
```

You are probably running an old stack version and need
to upgrade it.

#### Otherwise, if you get an error message like this...

```
No compiler found, expected minor version match with...
Try running "stack setup" to install the correct GHC...
```

Just do as it says and it will download and install
the correct compiler version:

```bash
stack setup
```

## Running *GHCi*

If you want to play with your solution in GHCi, just run the command:

```bash
stack ghci
```

## Feedback, Issues, Pull Requests

The [exercism/xhaskell](https://github.com/exercism/xhaskell) repository on
GitHub is the home for all of the Haskell exercises.

If you have feedback about an exercise, or want to help implementing a new
one, head over there and create an issue.  We'll do our best to help you!

## Hints

To complete this exercise you need to implement the function `score`,
that takes a sequence of bowling *rolls* and returns the final score or
the appropriate error:

```haskell
score :: [Int] -> Either BowlingError Int

data BowlingError = IncompleteGame
                  | InvalidRoll { rollIndex :: Int, rollValue :: Int }
                  deriving (Eq, Show)
```

You will find these definitions already in place, but it is up to you
to define the function.

Keep in mind that the test suite expects the rolls to be numbered
starting from zero.

## Source

The Bowling Game Kata at but UncleBob [http://butunclebob.com/ArticleS.UncleBob.TheBowlingGameKata](http://butunclebob.com/ArticleS.UncleBob.TheBowlingGameKata)

## Submitting Incomplete Problems
It's possible to submit an incomplete solution so you can see how others have completed the exercise.

