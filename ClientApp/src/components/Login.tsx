﻿import React, { SyntheticEvent, useState } from "react";
import { RouteComponentProps, withRouter, Redirect } from "react-router-dom";


const Login = () => {
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const [redirect, setRedirect] = useState(false);

    const submit = async(e: SyntheticEvent) => {
        e.preventDefault();

        await fetch('https://localhost:44349/api/account/login', {
            method: 'POST',
            headers: { 'Content-Type': 'application/json; charset=UTF-8' },
            credentials: "include", 
            body: JSON.stringify({
                email,
                password
               
            })
        });
        setRedirect(true);
    }

    if (redirect) {
        return <Redirect to="/" />;
    }

    

    return(
        
            <form onSubmit={submit}>

                <h1 className="h3 mb-3 fw-normal">Strefa Inwestora</h1>
                <div className="form-floating">
                    <input type="email" className="form-control" id="floatingInput" placeholder="name@example.com" required
                        onChange={e =>setEmail(e.target.value)}
                    />

                    <label htmlFor="floatingInput">Email address</label>
                </div><br/>
                <div className="form-floating">
                    <input type="password" className="form-control" id="floatingPassword" placeholder="Password" required
                           onChange={e => setPassword(e.target.value)}
                    />
                    <label htmlFor="floatingPassword">Password</label>
                </div>
                <button className="w-100 btn btn-lg btn-primary" type="submit">Sign in</button>


            </form>
        
    );
};
export default Login;