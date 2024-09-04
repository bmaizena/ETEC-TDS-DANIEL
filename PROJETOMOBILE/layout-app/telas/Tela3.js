import { StyleSheet, Text, View, Image } from 'react-native';



export function Tela3() {
  return (

    <View style={styles.container}>

    <Text style={styles.titulo}>Olá Mundo 2</Text>
    <Image source={require('../assets/images/dog.jpg')}/>

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

    titulo:{
        fontSize: 30,
        color: 'red'
    }
});