import org.scalatest.{FunSuite, Matchers}

import ZebraPuzzle._

class ZebraPuzzleTest extends FunSuite with Matchers {
  test("solve the Zebra Puzzle") {
    ZebraPuzzle.solve should be (
        Solution(waterDrinker = Norwegian,
                 zebraOwner = Japanese))
  }
}
