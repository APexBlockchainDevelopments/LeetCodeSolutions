using namespace std;
#include <vector>

class Solution {
public:
    vector<double> convertTemperature(double celsius) {
        double k = celsius + 273.15;
        double f = celsius * 1.8 + 32;

        vector<double> temps {k, f};
        return temps;
    }
};