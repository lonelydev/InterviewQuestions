# Utopian Tree

Once upon a time in Utopia, there was this wonderful tree that people were fond of. 
It had a very interesting growth pattern. Every year, it had `two growth cycles`.
One during monsoon and the other during summer. 

  * During monsoon, the tree grew `twice its height`
  * During summer, it grew just `1 additional meter`

If a utopian citizen were to plant a sapling of this tree of `1 meter` height in the onset of monsoon, could you tell what the height of the tree would be after `n` growth cycles would be?

## Key concepts

  * Count from the onset of monsoon. 
  * Initial height is `1 meter`
  * During monsoon, it grows twice its height. So by the end of first growth cycle it will be `2 meters` tall.
  * During summer, it grows an additional meter. So after 2 growth cycles it will be `3 meters` tall.
  * So growth can be categorized into two cycles:
    * Odd cycle - `2 x height`
    * Even cycle - `height + 1`

