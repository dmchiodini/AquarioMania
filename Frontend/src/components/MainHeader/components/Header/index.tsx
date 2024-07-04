import { getIcon } from '../../../../utils/getIcon';
import { Container, BoxItem, SocialContainer } from './styles';

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

      <BoxItem className="login">
        <button>ENTRAR</button>
        <button>REGISTRAR</button>

        <SocialContainer>
          <button>
            {getIcon({ name: 'uil:instagram', width: 20, height: 20 })}
          </button>
          <button>
            {getIcon({ name: 'fe:facebook', width: 20, height: 20 })}
          </button>
        </SocialContainer>
      </BoxItem>
    </Container>
  );
};

export default Header;
