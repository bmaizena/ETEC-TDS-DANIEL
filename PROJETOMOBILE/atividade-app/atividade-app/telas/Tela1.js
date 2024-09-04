import { StyleSheet, Text, View, Image } from 'react-native';



export function Tela1() {
  return (

    <View style={styles.container}>
    
    
        <Image source={require('../assets/images/bus.png')}/>
        <Text style={styles.titulo}>Seja Bem vindo</Text>
        <Text style={styles.info}>Login</Text>
        <Text style={styles.info}>Password</Text>
        <Text style={styles.entrar}>Entrar</Text>
        <Text style={styles.senha}>esqueceu sua senha?</Text>
        <Text style={styles.preferir}>OU SE PREFERIR</Text>
        
        <View style={styles.fotos}>
            <Image style={styles.fotogoogle} source={require('../assets/images/google.png')}/>
            <Image style={styles.fotoface} source={require('../assets/images/face.png')}/>
        </View>


    </View>
    
  );
}




const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: '#57A99D',
        alignItems: 'center',
        justifyContent: 'center'
    },

 

    titulo:{
        fontSize: 50,
        color: 'white',
        fontWeight: '200',
        margin: 20
    },

    info: {
        backgroundColor: 'rgba(217, 217, 217, 0.5)',
        borderRadius: 10,
        fontSize: 20,
        padding: 10,
        margin: 8,
        width: 250,
        color: 'rgba(0, 0, 0, 0.6)'
    },

    entrar: {
        backgroundColor: 'rgba(106, 163, 215, 0.7)',
        borderRadius: 10,
        fontWeight: 'bold',
        fontSize: 30,
        padding: 10,
        margin: 8,
        textAlign: 'center',
        width: 180,
        color: 'black'
    },

    senha: {
        fontSize: 15,
        color: 'black',
        marginBottom: 15
    },

    preferir: {
        fontSize: 35,
        color: 'black',
        marginTop: 10
    },

    fotos: {
        flexDirection: 'row'
    },

    fotogoogle: {
        marginRight: 30,
        width: 80,
        resizeMode: 'center'
    },
    fotoface: {
        width: 90,
        resizeMode: 'center'
    }
});
