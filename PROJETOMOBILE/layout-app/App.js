import { StatusBar } from 'expo-status-bar';
import { StyleSheet, Text, Image, View } from 'react-native';
import {Tela1} from './telas/Tela1.js';
import {Tela2} from './telas/Tela2.js';
import {Tela3} from './telas/Tela3.js';


export default function App() {
  return (

  
    <Tela3 />

  );
}


const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#DCDCDC',
    alignItems: 'center',
    justifyContent: 'center',
  }

  
});