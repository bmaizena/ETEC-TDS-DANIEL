import { StatusBar } from 'expo-status-bar';
import { StyleSheet, View, Text, Button} from 'react-native';

function debug(){
    console.log ("funcionou!!!!");
}

contador = 0 
function aumentarClick(v) {

    contador = contador + v
    
    console.log("contador +:" + contador )
}

function diminuirClick(v) {

  contador = contador - v
  
  console.log("contador +:" + contador )
}


export function Tela01() {
  return (

    <View style={styles.container}>
        <Text style={styles.titulo}>Contador</Text>
        <Text style={styles.botao}><Button  title="Gerar" onPress={()=> debug()}/></Text>

        <View style={styles.botoes}>
            <Button color='green' title="+1" onPress={()=> aumentarClick(1)}/>
            <Button color='red'title="+2" onPress={()=> aumentarClick(2)}/>
            <Button color='blue'title="+3" onPress={()=> aumentarClick(3)}/>
        </View>
        <View style={styles.botoes}>
            <Button color='pink' title="-1" onPress={()=> diminuirClick(1)}/>
            <Button color='orange'title="-2" onPress={()=> diminuirClick(2)}/>
            <Button color='violet'title="-3" onPress={()=> diminuirClick(3)}/>
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
  },

  botoes: {
    flexDirection: 'row',
    justifyContent: 'space-around',
    width: '50%',
    margin: 20
  },


});
