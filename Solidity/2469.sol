// SPDX-License-Identifier: GPL-3.0

pragma solidity ^0.8.4;

//kWEI
//fWEI

contract ConvertTheTemp{

    function getDecimals() public pure returns(uint256){
        return 18;
    }

    function convertTheTemperature(uint256 celciusWei) public pure returns(uint256[] memory){
        uint256[] memory ans;
        uint256 kWei = celciusWei + 273150000000000000000;
        uint256 fWei = celciusWei + ((celciusWei / 5) * 4) + 32000000000000000000;

        ans[0] = kWei;
        ans[1] = fWei;
        return ans;
    }
}