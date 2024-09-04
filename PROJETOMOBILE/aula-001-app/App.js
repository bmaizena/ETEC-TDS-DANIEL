import { StatusBar } from 'expo-status-bar';
import { Button, StyleSheet, Text, View } from 'react-native';

export default function App() {
  return (
    <View style={styles.container}>
      <Text style={{fontSize:26, fontWeight:'bold', color:'red', backgroundColor:'purple', borderRadius:15, width:'100%', borderColor:'black', borderWidth:1, textAlign:'center', padding:10 }}>teste❤👍</Text>
      <Text style={styles.segundoTexto}>Hello World!🗺</Text>
      <Text style={styles.terceiroTexto}>React Native⚽</Text>
      <Button title='meu primeiro botão'/>

      <View style={{flexDirection:'row'}}>
        <Text>Primeiro </Text>
        <Text>Segundo</Text>
      </View>
      <StatusBar style="auto" />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
  },

  segundoTexto: {
    backgroundColor:'green',
    color:'#c9c9c9',
    padding:15,
    borderWidth:1,
    width:'100%',
    borderRadius:15,
    fontWeight:"bold",
    fontSize:16,
    borderColor:'black',
    textAlign:'center'
  },

  terceiroTexto: {
    backgroundColor:'pink',
    color:'blue',
    padding:15,
    borderWidth:1,
    width:'100%',
    borderRadius:15,
    fontWeight:"bold",
    fontSize:16,
    borderColor:'black',
    textAlign:'center'
  }
});
