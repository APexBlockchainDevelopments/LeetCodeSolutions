public class Solution {
    public int[][] FlipAndInvertImage(int[][] image) {
        int[][] new2DArray = image;

        for(int i = 0; i < image.Length; i++){
            for(int j = 0; j < image[i].Length; j++){
                Console.WriteLine(image[i][j]);
                // need to flip row horiztionally
                new2DArray[i][image[i].Length - j] = image[i][j];
            }
            Console.WriteLine("\n");
        }
        return image;
    }
}