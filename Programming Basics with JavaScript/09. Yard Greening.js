function yardGreening(input){
    let sqrm = input[0];
    let sqrmSum = sqrm * 7.61;
    let discount = 0.18 * sqrmSum;
    let total = sqrmSum - discount;
    
    console.log(`The final price is: ${total} lv.`);
    console.log(`The discount is: ${discount} lv.`);
}
