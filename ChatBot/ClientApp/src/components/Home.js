import React, { Component } from 'react';
import { SimpleForm } from './chatbot';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
        <div>
            <SimpleForm />
        </div>
    );
  }
}
