import { StatusBar } from 'expo-status-bar';
import { StyleSheet} from 'react-native';
import { Tela01 } from './telas/Tela01'; 
import { TelaPlacar} from './telas/TelaPlacar' 
import { TelaPlacar2} from './telas/TelaPlacar2' 

export default function App() {
  return (
    <TelaPlacar2/>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#DCDCDC',
    alignItems: 'center',
    justifyContent: 'center',
  },
});
