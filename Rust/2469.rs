impl Solution {
    pub fn convert_temperature(celsius: f64) -> Vec<f64> {
        let k = celsius + 273.15;
        let f = celsius * 1.80 + 32.00;
        return vec![k, f]
    }
}