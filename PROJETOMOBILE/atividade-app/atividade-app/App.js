import { StatusBar } from 'expo-status-bar';
import { StyleSheet, Text, View } from 'react-native';
import { Tela1 } from './telas/Tela1';
import { Tela2 } from './telas/Tela2';

export default function App() {
  return (
    <View style={styles.container}>
      <Tela1/>
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
});
