import { getIcon } from '../../../../utils/getIcon';
import { Container, BoxItem } from './styles';

export const Header = () => {
  return (
    <Container>
      <BoxItem>
        <button>
          <span>SOBRE</span>
        </button>
        <button>
          <span>CONTATO</span>
        </button>
      </BoxItem>

      <BoxItem>
        <button>
          {getIcon({ name: 'uil:instagram', width: 25, height: 25 })}
        </button>
      </BoxItem>
    </Container>
  );
};

export default Header;
