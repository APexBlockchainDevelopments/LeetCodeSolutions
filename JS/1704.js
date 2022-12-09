/**
 * @param {string} s
 * @return {boolean}
 */
var halvesAreAlike = function(s) {
    let sLower = s.toLowerCase();
    let half = sLower.length /2;
    let firstHalf = [...sLower];
    let secondHalf = firstHalf.splice(half,sLower.length);
    let count = countVowels(firstHalf)
    let count2 = countVowels(secondHalf);

    if(count === count2){
        return true;
    } else {
        return false;
    }
};

var countVowels = function(word){
    let count = 0;
    for(let i = 0; i < word.length; i++){
        if(word[i] === 'a' || word[i] === 'e' || word[i] === 'i' || word[i] === 'o' || word[i] === 'u'){
            count++;
        }
    }
    return count;
}