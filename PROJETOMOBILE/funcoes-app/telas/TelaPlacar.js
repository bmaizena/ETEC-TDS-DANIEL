import { StatusBar } from 'expo-status-bar';
import { useState } from 'react';
import { StyleSheet, View, Text, Button, Alert} from 'react-native';


export function TelaPlacar() {

    const [contador, setContador] = useState(0)

    function placarAdd(v) {
        setContador (contador + v)
        
    }

    function removerUm() {
        if (contador > 0) {
            setContador (contador - 1)
        }
        else {
            Alert.alert("ja esta zerado");
        }
    }

  return (
    <View style={styles.container}>
         <Text style={styles.tituloPlacar}>Placar de Pontos</Text>
        <Text style={styles.titulo}>{contador}</Text>

        <View style={styles.placar}>
            <Button color='green' title='Add +1' onPress={()=> placarAdd(1)}></Button>
            <Button title='Zerar' onPress={()=> placarAdd(-contador)}></Button>
            <Button color='red' title='Del -1' onPress={()=> removerUm()}></Button>
        </View>
       

    </View>

  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#DCDCDC',
    alignItems: 'center',
    justifyContent: 'center',
  },

  titulo: {
    fontSize: 30,
    backgroundColor: 'gray',
    padding: 10,
    borderRadius: 10
  },

  placar: {
    flexDirection: 'row',
    justifyContent: 'space-around',
    width: '80%',
    margin:20,
    border: '1px solid black',
    padding: 5,
    borderRadius: 10
  },

  tituloPlacar: {
    fontSize:30,
    margin:20
  }

});
