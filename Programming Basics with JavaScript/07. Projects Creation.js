function projectCreation(input){
    let firstName = input[0];
    let projects = input[1];
    let hours = projects * 3;
  
    let data = (`The architect ${firstName} will need ${hours} hours to complete ${projects} project/s. `)
    console.log(data);
}
