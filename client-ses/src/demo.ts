import internal from "stream";

export interface Duck{
    name: string;
    numlegs: number;
    makeSound: (sound: string) => void;
}

const Duck1: Duck = {
    name: 'Rata',
    numlegs: 2,
    makeSound: (sound: string) => console.log(sound)
}

const Duck2 : Duck =
{
    name : 'Nicu',
    numlegs: 3,
    makeSound: (sound: string) => console.log(sound)
}

Duck1.makeSound('rata');


export const ducks = [Duck1, Duck2]