// Write your JavaScript code.
//fetch api for examples

console.log("fetch api data here !!!");
let t_body = document.getElementById("place_holder");

 fetch('https://jsonplaceholder.typicode.com/todos')
     .then(response => response.json()).then(el => { el.forEach ( item => {

         t_body.innerHTML += `
    <tr>
      <th scope="row">${item.id}</th>
      <td>${item.userId}</td>
      <td>${item.title}</td>
      <td>${item.completed}</td>
    </tr>
             `
     })
         }

         


 )

   // console.log(fetch_data);


