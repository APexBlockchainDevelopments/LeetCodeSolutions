impl Solution {
    pub fn convert_temperature(celsius: f64) -> Vec<f64> {
        let k = celsius + 273.15;
        let f = celsius * 1.80 + 32.00;
        return vec![k, f]
    }

    //second way
    pub fn convert_temperature2(celsius: f64) -> Vec<f64> {
        let k = celsius + 273.15;
        let f = celsius * 1.80 + 32.00;
        let result = vec![k, f];
        return result
    }

    ///Third way
    pub fn convert_temperature3(celsius: f64) -> Vec<f64> {
        let k = celsius + 273.15;
        let f = celsius * 1.80 + 32.00;

        let mut result = vec![];
        result[0] = k;
        result[1] = f;
        return result
    }

    //fourth way
    pub fn convert_temperature3(celsius: f64) -> Vec<f64> {
        let k = celsius + 273.15;
        let f = celsius * 1.80 + 32.00;

        let mut result : Vec<f64> = Vec::new();
        result.push(k);
        result.push(f);
        return result
    }
}