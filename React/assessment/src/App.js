import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';
import './bootstrap.min.css';

function App() {
  return (
    <div className="container-fluid">
      <div className="row">
        <div className="col-10 offset-1">
          <TitleComponent />
          <FormComponent />
          <OutputComponent />
        </div>
      </div>
    </div>
  );
}

function TitleComponent() {
  return (
    <div className="jumbotron">
      <h1>Contact us!</h1>
      <p>Please fill in the form below.</p>
    </div>
  );
}

function FormComponent() {
  const age = [...Array(99).keys];
  var options = age.map(() => {return <option>age</option>});

  return(
    <div className="form-group"> 
        <label>Firstname</label>
        <input type="text" className="form-control" placeholder="Enter firstname" />
        <label>Lastname</label>
        <input type="text" className="form-control" placeholder="Enter lastname" />
        <label>Age</label>
        <select className="form-control">
          {/* <option selected>Select age</option> */}
          {options}
        </select>
        <label>Message</label>
        <textarea />
      </div>
  );
}

function OutputComponent() {
  return(<div />);
}

export default App;
