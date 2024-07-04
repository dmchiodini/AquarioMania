import {
  Container,
  BoxContent,
  AvatarContainer,
  AvatarImage,
  InsigniaContainer,
  InsigniaImg,
  InfoUserContainer,
} from './styles';
import insignia from '../../assets/images/insignia.png';
import userimage from '../../assets/images/userimage.png';

const Aside = () => {
  return (
    <Container>
      <BoxContent>
        <AvatarContainer>
          <AvatarImage alt="" src={userimage} />
          <h1>Diego Chidodini</h1>
          <InfoUserContainer>
            <h1>MERGULHOU EM</h1>
            <span>26/06/2024</span>
          </InfoUserContainer>
          <InfoUserContainer>
            <h1>TIPO DE ÁGUA</h1>
            <span>Água Doce</span>
          </InfoUserContainer>
          <InfoUserContainer>
            <h1>POSTAGENS</h1>
            <span>15</span>
          </InfoUserContainer>
          <InfoUserContainer>
            <h1>COMENTÁRIOS</h1>
            <span>85</span>
          </InfoUserContainer>
        </AvatarContainer>
        <InsigniaContainer>
          <InsigniaImg alt="" src={insignia} />
        </InsigniaContainer>
      </BoxContent>
    </Container>
  );
};

export default Aside;
