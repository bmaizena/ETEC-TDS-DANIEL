import { StyleSheet, Text, View, Image } from 'react-native';



export function Tela2() {
  return (

    <View style={styles.container}>

    
    <Image source={require('../assets/images/sualoc.png')}/>
    <Image style={styles.mapa} source={require('../assets/images/mapa.jpg')}/>
    <Text style={styles.pontos}>6 pontos de ônibus próximos a você</Text>
    <Image style={styles.menu} source={require('../assets/images/menu.png')}/>
    </View>
    
  );
}

const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: '#57A99D',
        alignItems: 'center',
        justifyContent: 'center',
    },

    mapa: {
        marginTop: 40,
        width: 450,
        resizeMode: 'center',
        borderRadius: 10
    },

    pontos: {
        margin: 10,
        borderRadius: 10,
        fontSize: 20,
        width: 200,
        backgroundColor: 'rgba(231, 204, 65, 0.82)',
        textAlign: 'center'
    },

    menu: {
        width: '100%'
    }
    
});
