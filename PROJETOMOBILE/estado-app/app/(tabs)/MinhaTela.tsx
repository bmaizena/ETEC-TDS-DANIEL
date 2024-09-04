import { Text, View, StyleSheet, FlatList, Image, ScrollView } from "react-native";
import registros from './registros.json'
import { Collapsible } from '@/components/Collapsible';
import { ThemedText } from '@/components/ThemedText';

export default function MinhaTela() {

  return (
   <ScrollView style={{backgroundColor:'#fff'}}>
      
      <View style={styles.container}>
      <Text style={{fontSize:30, marginTop:8}}>Registros</Text>
      <FlatList
          data={registros}
          style={styles.flatStyle}
          renderItem={({item}) =>
            
          <View style={styles.viewCollapsible}>
            
          <Collapsible title={
          <View style={styles.tituloCollapsible}>
              <Text>{item.sexo === "F" ?
              <Image style={{width:20, height:20, backgroundColor:'#DDA0DD', borderRadius:10}} source={require('../../assets/images/woman.png')}/> :
              <Image style={{width:20, height:20, backgroundColor:'#4682B4', borderRadius:10}} source={require('../../assets/images/man.png')}/>}
              </Text>
              <Text>  {item.name}</Text>
              
          </View>}> 
            
            <ThemedText style={styles.themed}>ID: <Text style={styles.textoThemed}>{item.id}</Text></ThemedText>

            <ThemedText style={styles.themed}>NOME: <Text style={styles.textoThemed}>{item.name}</Text> </ThemedText>

            <ThemedText style={styles.themed}>EMAIL: <Text style={styles.textoThemed}>{item.email}</Text> </ThemedText>

            <ThemedText style={styles.themed}>TEL: <Text style={styles.textoThemed}>{item.telefone}</Text> </ThemedText>

            <ThemedText style={styles.themed}>NASCIMENTO: <Text style={styles.textoThemed}>{item.data_nascimento}</Text> </ThemedText>

            <ThemedText  style={styles.themed}>SEXO: <Text style={styles.textoThemed}>{item.sexo}</Text> </ThemedText>
            
          </Collapsible>
          </View>}
   
          />
      
      </View>
      
    </ScrollView> 
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor:'#fff',
    alignItems:'center',
  },
  tituloCollapsible:{
    flexDirection:'row',
    padding:10, 
    backgroundColor:'#E8E8E8', 
    fontSize:18
  },
  viewCollapsible:{
    borderWidth:2, 
    borderColor:'black', 
    margin:10, 
    borderRadius:30, 
    padding:15, 
    backgroundColor:'#E8E8E8', 
    shadowColor: '#171717',
    shadowOffset: {width: -2, height: 4},
    shadowOpacity: 0.1,
    shadowRadius: 3,
  },
  themed:{
    fontSize:17, 
    fontWeight:'bold', 
    padding:8,
    
  },
  textoThemed:{
    fontSize:16, 
    fontWeight:'normal'
  },
  flatStyle:{
    width:400, 
    marginTop:20, 
    padding:20, 
    backgroundColor:'#D0D0D0', 
    borderWidth:1, 
    borderRadius:30,
    shadowColor: '#171717',
    shadowOffset: {width: 5, height: 4},
    shadowOpacity: 0.1,
    shadowRadius: 3,
  }
});
