import { StatusBar } from 'expo-status-bar';
import { useState } from 'react';
import { StyleSheet, View, Text, Button, Alert} from 'react-native';
import { TouchableOpacity } from 'react-native-web';


export function TelaPlacar2() {
    const [contador, setContador] = useState(0)

    function placarAdd(v) {
        setContador (contador + v)
        
    }

    function removerUm(v) {
        if (contador - v > 0) {
            setContador (contador - v)
        }
        else {
            setContador (0)
        }
    }

  return (

    
    <View style={styles.container}>
        <Text style={styles.titulo}>Placar</Text>

        <View style={styles.menu}>

            <View style={styles.menuLutador}>
                <Text style={{fontSize:40,  margin: 'auto', color: 'white'}}>Lutador 🥋</Text>
                <Text style={{fontSize:60, margin: 'auto', color: 'white'}}>{contador}</Text>

                <View style={styles.botoesMais}>
                    <TouchableOpacity style={styles.botao} onPress={()=> placarAdd(2)}><Text style={styles.textoBotao}>+2</Text></TouchableOpacity>
                    <TouchableOpacity style={styles.botao} onPress={()=> placarAdd(3)}><Text style={styles.textoBotao}>+3</Text></TouchableOpacity>
                    <TouchableOpacity style={styles.botao} onPress={()=> placarAdd(4)}><Text style={styles.textoBotao}>+4</Text></TouchableOpacity>
                </View>

                <View style={styles.botoesMenos}>
                    <TouchableOpacity style={styles.botao} onPress={()=> removerUm(2)}><Text style={styles.textoBotao}>-2</Text></TouchableOpacity>
                    <TouchableOpacity style={styles.botao} onPress={()=> removerUm(3)}><Text style={styles.textoBotao}>-3</Text></TouchableOpacity>
                    <TouchableOpacity style={styles.botao} onPress={()=> removerUm(4)}><Text style={styles.textoBotao}>-4</Text></TouchableOpacity>
                </View>
            </View>

                <View style={styles.segundoPlacar}>
                  <View style={styles.ponts}>
                      <TouchableOpacity style={styles.botao} ><Text style={styles.textoBotao}>-</Text></TouchableOpacity>
                      <Text style={styles.textoBotaoPlacar}>00</Text>
                      <TouchableOpacity style={styles.botaoGreen} ><Text style={styles.textoBotao}>+</Text></TouchableOpacity>
                  </View>
                  <View style={styles.ponts2}>
                      <TouchableOpacity style={styles.botao}><Text style={styles.textoBotao}>-</Text></TouchableOpacity>
                      <Text style={styles.textoBotaoPlacar}>00</Text>
                      <TouchableOpacity style={styles.botaoGreen}><Text style={{fontSize: 19, fontWeight:'bold'}}>+</Text></TouchableOpacity>
                  </View>
                </View>
           
       

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
    fontSize: 60,
    color: 'white',
    backgroundColor: 'black',
    padding: 10,
    width: 500,
    textAlign: 'center',
    borderTopRightRadius:50,
    borderTopLeftRadius:50,
    shadowColor: '#171717',
    shadowOffset: {width: -2, height: 10},
    shadowOpacity: 0.2,
    shadowRadius: 3,
  },

  menu: {
    backgroundColor: 'gray',
    width:500,
    flexDirection: 'row',
    borderBottomRightRadius:50,
    borderBottomLeftRadius:50,
    shadowColor: '#171717',
    shadowOffset: {width: -2, height: 4},
    shadowOpacity: 0.2,
    shadowRadius: 3,
  },

  menuLutador: {
    backgroundColor: '#A9A9A9',
    width: 259,
    padding:10,
    borderBottomLeftRadius:50
    
  },

  botoesMais: {
    flexDirection: 'row',
    margin: 'auto',
    padding:10,
    justifyContent: 'space-between',
    width: '100%'
    
    
  },

  botoesMenos: {
    flexDirection: 'row',
    margin: 'auto',
    justifyContent: 'space-between',
    width: '90%'
  },

  botao:{
    backgroundColor:'red',
    borderRadius: 50,
    paddingHorizontal:13,
    paddingTop:4,
    height: 40,
    margin:10,
      
  },

  botaoGreen:{
    backgroundColor:'green',
    borderRadius: 50,
    paddingHorizontal:13,
    paddingTop:4,
    height: 40,
    margin:10
    
  },

  textoBotao:{
    fontSize: 20, 
    fontWeight:'bold'
  },

  textoBotaoPlacar:{
    fontSize: 30, 
    fontWeight:'bold',
    marginTop:10
  },
  


  ponts: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    fontSize:20,
    margin: 'auto',
   
  },

  ponts2: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    fontSize:20,
    margin: 'auto'
  },

  segundoPlacar:{
    flexDirection: 'column',
    margin:'auto'
  }


});
