impl Solution {
    pub fn defang_i_paddr(address: String) -> String {
        let result = address.replace(".", "[.]");
        return result
    }
}