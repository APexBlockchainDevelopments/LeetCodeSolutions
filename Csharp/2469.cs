public class Solution {
    public double[] ConvertTemperature(double celsius) {
        double fahrenheit = celsius * 1.80 + 32.00;
        double kelvin = celsius + 273.15;
        double[] result = {kelvin, fahrenheit};
        return result;
    }
}