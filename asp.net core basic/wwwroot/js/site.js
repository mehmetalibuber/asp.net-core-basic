// Write your JavaScript code.
//fetch api for examples
let path = window.location.pathname;
//console.log(path)
if (path === "/Home/hizmetler") {


console.log("fetch api data here !!!");
let t_body = document.getElementById("place_holder");

 fetch('https://jsonplaceholder.typicode.com/todos')
     .then(response => response.json()).then(el => { el.slice(0,15).forEach ( item => {
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
}

