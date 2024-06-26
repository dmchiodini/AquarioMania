import {
  Container,
  BoxContent,
  AvatarContainer,
  AvatarImage,
  UserName,
  InsigniaContainer,
  InsigniaImg,
  TypeUser,
} from './styles';
import insignia from '../../assets/images/insignia.png';
import userimage from '../../assets/images/userimage.png';

const Aside = () => {
  return (
    <Container>
      <BoxContent>
        <AvatarContainer>
          <AvatarImage alt="" src={userimage} />
          <UserName>Diego Chidodini</UserName>
          <TypeUser>Água Doce</TypeUser>
        </AvatarContainer>
        <InsigniaContainer>
          <InsigniaImg alt="" src={insignia} />
        </InsigniaContainer>
      </BoxContent>
    </Container>
  );
};

export default Aside;
