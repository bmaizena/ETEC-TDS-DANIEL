import { StyleSheet, View, Text, FlatList, ScrollView } from 'react-native';
import {useEffect, useState} from "react";

export default function async() {

const [isLoading, setLoading] = useState(true);
const [data, setData] = useState([]);

const getEstados = async ()=> {
    try {
        const response = await fetch('https://servicodados.ibge.gov.br/api/v1/localidades/estados?orderBy=nome');
        const json = await response.json();
        console.log(json);
        setData(json);
    }
    catch(error){
        console.error(error);
    }
    finally{
        setLoading(false);
    }
};

useEffect(()=>{
  getEstados();
  setLoading(true);
}, []);

  return (
    <View style={styles.container}>
      <ScrollView style={styles.main}>
        <Text style={{textAlign: "center", fontSize:30}}>Estados IBGE</Text>
        <FlatList
        data={data}
        keyExtractor={({id})=>id}
        renderItem={({item}) =>
          (<View>
            <Text style={styles.textoflat}>
              [{item.sigla}] - {item.nome} 
            </Text>
        
          </View>)}
        />
      </ScrollView>
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

  main:{
    marginTop:10,
    padding:10,
    width:500,
    backgroundColor:'#fff',
    borderRadius:9
  },
  textoflat:{
    borderWidth:1, 
    margin:5, 
    padding:8, 
    borderRadius:7, 
    backgroundColor: '#D0D0D0'
  }
});
