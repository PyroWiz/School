import { user } from "./user.js";

export function registerUser(event)
{
    event.preventDefault();

    let fullname = document.querySelector('#username').value;
    let email = document.querySelector('#email').value;
    let password = document.querySelector('#password').value;
    let c_password = document.querySelector('#c_password').value;

    if (password !== c_password)
    {
        alert("Passwords do not match!");
        return;
    }

    let u = new user(fullname, email, password);
    console.log(u);

    
}

