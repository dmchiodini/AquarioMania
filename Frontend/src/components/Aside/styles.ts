import styled from 'styled-components';

export const Container = styled.div`
  grid-area: AS;
  background-color: ${(prop) => prop.theme.colors.white};
  height: 100%;
  padding: 5px;
`;

export const BoxContent = styled.div`
  background-color: ${(prop) => prop.theme.colors.darker};
  width: 100%;
  border-radius: 6px;
  min-height: 600px;
  display: flex;
  flex-direction: column;
  justify-content: space-between;
`;

export const AvatarContainer = styled.div`
  width: 100%;
  height: 100%;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  padding: 20px;
`;

export const AvatarImage = styled.img`
  height: 150px;
  width: 150px;
  border-radius: 50%;
  background-color: #dfdfdf;
  margin: 15px;
  background-size: cover;
`;

export const UserName = styled.span`
  font-size: 16px;
  color: ${(props) => props.theme.colors.white};
  font-weight: 500;
  font-size: 16px;
`;

export const TypeUser = styled.span`
  font-size: 16px;
  color: ${(props) => props.theme.colors.gray};
  font-weight: 500;
  font-size: 14px;
`;

export const InsigniaContainer = styled.div`
  width: 100%;
  height: 100%;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  margin-bottom: 40px;
`;

export const InsigniaImg = styled.img`
  width: 140px;
  height: 180px;
`;
