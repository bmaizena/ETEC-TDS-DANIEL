import { StyleSheet, View, Text, FlatList, ScrollView, ActivityIndicator } from 'react-native';
import {useEffect, useState} from "react";

export default function async() {

const [isLoading, setLoading] = useState(true);
const [data, setData] = useState([]);

const getEstados = async ()=> {
    try {
        const response = await fetch('https://servicodados.ibge.gov.br/api/v1/localidades/estados/35/municipios?orderBy=nome');
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
}, []);

if (isLoading) {
  return (
    <View style={[styles.loadingContainer]}>
      <ActivityIndicator size="large" />
    </View>
  );
}

  return (
    <View style={styles.container}>
      <ScrollView style={styles.main}>
        <Text style={{textAlign: "center", fontSize:30}}>Municípios SP</Text>
        <FlatList
        data={data}
        keyExtractor={({id})=>id}
        renderItem={({item}) =>
          (<View>
            <Text style={styles.textoflat}>
              {item.microrregiao.mesorregiao.UF.sigla} - {item.nome} - {item.microrregiao.mesorregiao.UF.regiao.nome}
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
  },
  loadingContainer: {
    justifyContent: 'center',
    alignItems: 'center',
    flex: 1,
  },
  loadingText: {
    fontSize: 20,
    fontWeight: 'bold',
  }
});
