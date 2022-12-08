//SPDX-License-Identifier: GPL-3.0

pragma solidity ^0.8.4;


contract AddTwoIntegers{

    function sum(int8 num1, int8 num2) public pure returns(int16){
        return num1 + num2;
    }

}