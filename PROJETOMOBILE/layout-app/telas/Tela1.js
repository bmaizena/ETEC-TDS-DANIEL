
import { StyleSheet, Text, View } from 'react-native';



export function Tela1() {
  return (

    <View style={styles.container}>

    <Text>Olá Mundo</Text>

    </View>
    
  );
}




const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: '#DCDCDC',
        alignItems: 'center',
        justifyContent: 'center',
    }
});

