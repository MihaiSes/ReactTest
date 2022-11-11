import React from 'react'
import {Duck} from './demo'

interface Props{
    duck: Duck;
}


export default function DuckItem({duck}: Props)
{
    return(
        <div>
        <span> {duck.name}</span>
        <button onClick={() => duck.makeSound(duck.name + 'button')}>Click me</button>
    </div>
    )
}